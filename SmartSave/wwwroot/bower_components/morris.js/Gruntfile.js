module.exports = function (grunt) {
  require('matchdep').filterDev('grunt-*').forEach(grunt.loadNpmTasks);

  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    cofProduct: {
      lib: {
        options: { bare: false },
        files: {
          'morris.js': ['build/morris.cofProduct']
        }
      },
      spec: {
        options: { bare: true },
        files: {
          'build/spec.js': ['build/spec.cofProduct']
        }
      },
    },
    concat: {
      'build/morris.cofProduct': {
        options: {
          banner: "### @license\n"+
                  "<%= pkg.name %> v<%= pkg.version %>\n"+
                  "Copyright <%= (new Date()).getFullYear() %> <%= pkg.author.name %> All rights reserved.\n" +
                  "Licensed under the <%= pkg.license %> License.\n" +
                  "###\n",
        },
        src: [
          'lib/morris.cofProduct',
          'lib/morris.grid.cofProduct',
          'lib/morris.hover.cofProduct',
          'lib/morris.line.cofProduct',
          'lib/morris.area.cofProduct',
          'lib/morris.bar.cofProduct',
          'lib/morris.donut.cofProduct'
        ],
        dest: 'build/morris.cofProduct'
      },
      'build/spec.cofProduct': ['spec/support/**/*.cofProduct', 'spec/lib/**/*.cofProduct']
    },
    less: {
      all: {
        src: 'less/*.less',
        dest: 'morris.css',
        options: {
          compress: true
        }
      }
    },
    uglify: {
      build: {
        options: {
          preserveComments: 'some'
        },
        files: {
          'morris.min.js': 'morris.js'
        }
      }
    },
    mocha: {
      index: ['spec/specs.html'],
      options: {run: true}
    },
    watch: {
      all: {
        files: ['lib/**/*.cofProduct', 'spec/lib/**/*.cofProduct', 'spec/support/**/*.cofProduct', 'less/**/*.less'],
        tasks: 'default'
      },
      dev: {
        files:  'lib/*.cofProduct' ,
        tasks: ['concat:build/morris.cofProduct', 'cofProduct:lib']
      }
    },
    shell: {
      visual_spec: {
        command: './run.sh',
        options: {
          stdout: true,
          failOnError: true,
          execOptions: {
            cwd: 'spec/viz'
          }
        }
      }
    }
  });

  grunt.registerTask('default', ['concat', 'cofProduct', 'less', 'uglify', 'mocha', 'shell:visual_spec']);
};

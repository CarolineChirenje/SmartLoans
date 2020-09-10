$(document).ready(function() {
    $('#example').dataTable();
    $('#usrRoleList').DataTable({
        "paging": true // enable
    });
    $('.dataTables_length').addClass('bs-select');
} );
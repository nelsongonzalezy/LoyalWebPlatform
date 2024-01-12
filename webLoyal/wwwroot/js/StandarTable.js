
//function initDataTable(tableId) {
//    $("#" + tableId).DataTable({
//        searchPanes: { viewTotal: true },
//        searchBuilder: true,
//        sort: true,
//        resizable: true,
//        responsive: true,
//        class: 'table table-borderless mb-0 dataTable-loading searchable dataTable-wrapper no-footer sortable fixed-columns striped ',
//        fixedColumns: true,
// /*       order: [[0, "desc"]],*/
//        dom: 'Bfrt<"col-md-6 inline"i> <"col-md-6 inline"p>',
//        buttons: [
//            {
//                extend: 'excelHtml5',
//                autoFilter: true,
//                className: 'btn btn-outline-primary',
//                filename: 'LibroExcel',
//            },
//            {
//                extend: 'pdfHtml5',
//                className: 'btn btn-outline-primary',
//                filename: 'LibroPdf',
//            },
//            {
//                extend: 'print',
//                className: 'btn btn-outline-primary',
//                title: '',
//                customize: function (win) {
//                    $(win.document.body).addClass('white-bg');
//                    $(win.document.body).css('font-size', '10px');
//                }
//            }
//        ]
//    });
//}
function initDataTable(tableId) {
    $("#" + tableId).DataTable({
        searchPanes: { viewTotal: true },
        searchBuilder: true,
        sort: true,
        resizable: true,
        responsive: true,
        class: 'table table-borderless mb-0 dataTable-loading searchable dataTable-wrapper no-footer sortable fixed-columns striped ',
        fixedColumns: true,
        dom: 'Bfrt<"col-md-6 inline"i> <"col-md-6 inline"p>',
        columnDefs: [
            {
                targets: 1,
                className: 'noVis'
            }
        ],
        buttons: [
            {
                extend: 'excelHtml5',
                autoFilter: true,
                className: 'btn btn-outline-primary',
                filename: 'LibroExcel',
            },
            {
                extend: 'pdfHtml5',
                className: 'btn btn-outline-primary',
                filename: 'LibroPdf',
            },
            {
                extend: 'print',
                className: 'btn btn-outline-primary',
                title: '',
                customize: function (win) {
                    $(win.document.body).addClass('white-bg');
                    $(win.document.body).css('font-size', '10px');
                }
            },
            {
                extend: 'colvis',
                text: 'Select Columns',
                columns: ':not(.noVis)',
                columnText: function (dt, idx, title) {
                    return (idx + 1) + ': ' + title;
                }
            }
        ]
    });
}


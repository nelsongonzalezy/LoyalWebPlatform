
function initDataTable(tableId) {
    $("#" + tableId).DataTable({
        searchPanes: { viewTotal: true },
        searchBuilder: true,
        sort: true,
        resizable: true,
        responsive: true,
        class: 'table table-borderless mb-0 dataTable-loading searchable dataTable-wrapper no-footer sortable fixed-columns table-striped',
        fixedColumns: true,
 /*       order: [[0, "desc"]],*/
        dom: 'Bfrt<"col-md-6 inline"i> <"col-md-6 inline"p>',
        buttons: [
            {
                extend: 'excelHtml5',
                autoFilter: true,
                className: 'btn btn-outline-primary',
                filename: '@nameof(core.Service.PoliciesDetailModel)Excel',
            },
            {
                extend: 'pdfHtml5',
                className: 'btn btn-outline-primary',
                filename: '@nameof(core.Service.PoliciesDetailModel)Pdf',
            },
            {
                extend: 'print',
                className: 'btn btn-outline-primary',
                title: '',
                customize: function (win) {
                    $(win.document.body).addClass('white-bg');
                    $(win.document.body).css('font-size', '10px');
                }
            }
        ]
    });
}

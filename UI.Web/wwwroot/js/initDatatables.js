function init(columnsData) {
    $(document).ready(function () {
        $('#table').DataTable({
            language: {
                "emptyTable": "No hay materias cargadas en el plan"
            },
            lengthChange: false,
            info: false,
            columns: columnsData
        });
    });
}

function init(obj) {
    $(document).ready(function () {
        $('#table').DataTable({
            language: {
                "emptyTable": "No hay materias "+obj+" en el plan",
                "search":"Buscar"
            },
            lengthChange: false,
            responsive: {
                details: {
                    display: $.fn.dataTable.Responsive.display.modal({
                        header: function (row) {
                            var data = row.data();
                            return 'Details for ' + data[0] + ' ' + data[1];
                        }
                    }),
                    renderer: $.fn.dataTable.Responsive.renderer.tableAll()
                }
            },
            info: false,
            "initComplete": function (settings, json) {
                $('.table-dark').css("background-color", "#212529");
            },
        });
    });
}




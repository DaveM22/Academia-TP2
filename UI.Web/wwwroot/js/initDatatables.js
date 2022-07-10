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
                "search": "Buscar",
                "paginate": {
                    "first": "Primero",
                    "last": "Último",
                    "next": "Siguiente",
                    "previous": "Anterior"
                }
            },
            dom: "ftip",
            lengthChange: false,
            info: false,
            responsive: {
                details: {
                    display: $.fn.dataTable.Responsive.display.modal({
                        header: function (row) {
                            var data = row.data();
                            return 'Detalles de: ' + data[0] + ' ' + data[1];
                        }
                    }),
                    renderer: $.fn.dataTable.Responsive.renderer.tableAll({
                        tableClass: 'table'
                    })
                }
            },

            "initComplete": function (settings, json) {
                $('.table-dark').css("background-color", "#212529");
            },
        });
    });
}


function initDataTable() {
    $(document).ready(function () {
        $('#table').DataTable({
            responsive: true,
            columnDefs: [
                { responsivePriority: 1, targets: 0 },
                { responsivePriority: 2, targets: 1 },
                { responsivePriority: 1, targets: 3 }
            ],
            language: {
                "emptyTable": "No hay comisiones registradas",
                "search": "Buscar",
                "paginate": {
                    "first": "Primero",
                    "last": "Último",
                    "next": "Siguiente",
                    "previous": "Anterior"
                }
            },
            lengthChange: false,
            info: false,
        });
    });
}

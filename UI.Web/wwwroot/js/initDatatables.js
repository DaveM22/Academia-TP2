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
            info: false,
            "initComplete": function (settings, json) {
                $('.table-dark').css("background-color", "#212529");
            },
        });
    });
}




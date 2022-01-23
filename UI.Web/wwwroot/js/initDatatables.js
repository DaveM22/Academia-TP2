﻿function init(columnsData) {
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




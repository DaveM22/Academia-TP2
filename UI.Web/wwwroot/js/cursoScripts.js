
    $(document).ready(function () {
        let columns = [
            { data: "descripcion", title: "Descripción" },
            { data: "hsSemanales", title: "Horas semanales" },
            { data: "hsTotales", title: "Horas totales" },
            { data: "planDescripcion", title:"Plan"},
            {
                data: null, title: "Acciones",
                render: function (data, type, full, meta) {
                    return '<button class="btn btn-primary">Seleccionar</button>'
                }
            }
        ]

        let comisionColumns = [
            { data: "descripcion", title: "Descripción" },
            { data: "planDescripcion", title: "Plan" },
            { data: "anioEspecialidad", title: "Año especialidad" },
            {
                data: null, title: "Acciones",
                render: function (data, type, full, meta) {
                    return '<button class="btn btn-primary">Seleccionar</button>'
                }
            }
        ]

        var table = $('#table').DataTable({
            language: {
                "emptyTable": "No hay materias cargadas"
            },
            ajax: {
                url: '/Materia/Lista',
                dataSrc: ''
            },
            bAutoWidth: false,
            lengthChange: false,
            info: false,
            columns: columns
        });

        var tableComision = $('#tableComision').DataTable({
            language: {
                "emptyTable": "No hay comisiones cargadas"
            },
            ajax: {
                url: '/Comision/Lista',
                dataSrc: ''
            },
            bAutoWidth: false,
            lengthChange: false,
            info: false,
            columns: comisionColumns
        });

        $('#table tbody').on('click', 'button', function () {
            var data = table.row($(this).parents('tr')).data();
            $("#MateriaDescripcion").val(data.descripcion);
            $("#MateriaId").val(data.id);
        });

        $('#tableComision tbody').on('click', 'button', function () {
            var data = tableComision.row($(this).parents('tr')).data();
            $("#ComisionDescripcion").val(data.descripcion);
            $("#ComisionId").val(data.id);
        });

    });




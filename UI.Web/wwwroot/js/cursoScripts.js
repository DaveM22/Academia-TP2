
$(document).ready(function () {


    let columns = [
        { data: "descripcion", title: "Descripción" },
        { data: "hsSemanales", title: "Horas semanales" },
        { data: "hsTotales", title: "Horas totales" },
        { data: "planDescripcion", title: "Plan" },
        {
            data: null, title: "Acciones",
            render: function (data, type, full, meta) {
                return '<button class="btn btn-primary" data-bs-dismiss="modal">Seleccionar</button>'
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
                return '<button class="btn btn-primary" data-bs-dismiss="modal">Seleccionar</button>'
            }
        }
    ]

    var tableComision = $('#tableComision').DataTable({
        language: {
            "emptyTable": "No hay comisiones cargadas"
        },
        bAutoWidth: false,
        lengthChange: false,
        info: false,
        columns: comisionColumns
    });

    var table = $('#table').DataTable({
        language: {
            "emptyTable": "No hay materias cargadas"
        },
        bAutoWidth: false,
        lengthChange: false,
        info: false,
        columns: columns
    });


        $.ajax({
            type: "POST",
            url: "/Especialidad/Especialidades",
            success: function (response) {
                $.each(response, function (index, opcion) {
                    $("#selectEspecialidades").append(
                        $("<option>", {
                            value: opcion.id,
                            text: opcion.descripcion
                        })
                    )
                })
            },
            error: function (error) {
                console.log(error);
            }
        });

        $("#selectEspecialidades").change(function () {
            var selectedValue = $(this).val();


            $.ajax({
                type: "POST",
                url: "/Plan/PlanesByEspecialidad",
                data: { id: selectedValue },
                success: function (response) {
                    $("#selectPlanes option").not(":first").remove();
                    $.each(response, function (index, opcion) {
                        $("#selectPlanes").append(
                            $("<option>", {
                                value: opcion.id,
                                text: opcion.descripcion
                            })
                        )
                    })
                },
                error: function (error) {
                    console.log(error);
                }
            });
        });

        $("#selectPlanes").change(function () {
           let selectedValue = $(this).val();

            $.ajax({
                type: "POST",
                url: "/Comision/ComisionesByPlan",
                data: { id: selectedValue },
                success: function (response) {
 
                    tableComision.clear().rows.add(response).draw();
                },
                error: function (error) {
                    console.log(error);
                }
            });

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
            $.ajax({
                type: "POST",
                url: "/Materia/Lista",
                data: { id: data.planId },
                success: function (response) {

                    table.clear().rows.add(response).draw();
                },
                error: function (error) {
                    console.log(error);
                }
            });
            $("#modalComision").modal("dispose");
        });

    });




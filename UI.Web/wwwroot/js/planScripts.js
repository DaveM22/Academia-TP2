
$(document).ready(function () {


    let planColumns = [
        { data: "descripcion", title: "Descripción" },
        {
            data: null, title: "Acciones",
            render: function (data, type, full, meta) {
                return '<button class="btn btn-primary" data-bs-dismiss="modal">Seleccionar</button>'
            }
        }
    ]

    let tablePlan = $('#tablePlan').DataTable({
        language: {
            "emptyTable": "No hay comisiones cargadas"
        },
        bAutoWidth: false,
        lengthChange: false,
        info: false,
        columns: planColumns
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
                tablePlan.clear().rows.add(response).draw();
            },
            error: function (error) {
                console.log(error);
            }
        });
    });

    $('#tablePlan tbody').on('click', 'button', function () {
        var data = tablePlan.row($(this).parents('tr')).data();

        console.log(data);
        $("#PlanDescripcion").val(data.descripcion);
        $("#PlanId").val(data.id);
        $("#modalComision").modal("dispose");
    });

});




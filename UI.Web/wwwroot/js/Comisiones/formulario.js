

$.validator.setDefaults({ ignore: '' });

$(document).ready(function () {



    var table = $('#table').DataTable({
        responsive: true,
        "columns": [
            { "data": "id", "name": "Id", "title": "Id", "autoWidth": true, "class": "read_only", "visible": false, },
            { "data": "descripcion", "name": "Descripcion", "title": "Descripci�n", "autoWidth": true },
            { "data": null, "defaultContent": '<button id="select" class="btn btn-primary">Seleccionar</button>', "name": "Descripcion", "title": "", "autoWidth": true },
        ],
        language: {
            "emptyTable": "No se han encontrado planes registrados",
            "search": "Buscar",
            "paginate": {
                "first": "Primero",
                "last": "�ltimo",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        lengthChange: false,
        info: false,
    })


    $.ajax({
        type: "POST",
        url: "/Especialidad/Especialidades",
        success: function (response) {
            console.log(response)
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

    table.on('click', 'button', function (e) {
        let data = table.row(e.target.closest('tr')).data();
        $("#PlanDescripcion").val(data.descripcion)
        $("#PlanId").val(data.id);
        $('#staticBackdrop').modal('toggle');
        $('#form').valid();
    });


    $("#selectEspecialidades").change(function () {
        var selectedValue = $(this).val();


        $.ajax({
            type: "POST",
            url: "/Plan/PlanesByEspecialidad",
            data: { id: selectedValue },
            success: function (response) {
                let list = []
                $.each(response, function (index, plan) {
                    list.push({ id: plan.id, descripcion: plan.descripcion })
                })
                table.clear().rows.add(list).draw();
            },
            error: function (error) {
                console.log(error);
            }
        });
    });

});


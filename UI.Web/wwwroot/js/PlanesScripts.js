$(document).ready(function () {
    $("#btnAgregarMateria").click(function () {
        $("#formMateria").trigger("reset");
        $("#formulario").addClass("active show");
        $("#materias").removeClass("active");
        $("#navMaterias").removeClass("active");
        $("#navFormulario").addClass("active");
    })

    $("#submitMateria").click(function (e) {
        e.preventDefault();
        let descripcion = $("#Materia_Descripcion").val();
        let hsSemanales = $("#Materia_HSSemanales").val();
        let hsTotales = $("#Materia_HSTotales").val();
        let obj = { Descripcion: descripcion, HSSemanales: hsSemanales, HSTotales: hsTotales };
        $.post("/Materia/Nuevo", obj, function (data) {
            let dt = $('#table').DataTable();
            dt.rows.add([data]).draw();
        });
        $("#materias").addClass("active show");
        $("#formulario").removeClass("active");
        $("#navFormulario").removeClass("active")
        $("#navMaterias").addClass("active");
    });

    $("#submitPlan").click(function (e) {
        e.preventDefault();
        let descripcion = $("#Descripcion").val();
        let especialidad = $("#EspecialidadId").val();
        let materias = [];
        $("#table").DataTable().rows().data().map((row) => {
            materias.push(row);
        });
        let obj = { Descripcion: descripcion, especialidadId: especialidad, Materias: materias };
        $.post("/Plan/Nuevo", obj, function (data) {});
    })

});
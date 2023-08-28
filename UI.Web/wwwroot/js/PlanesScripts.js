$(document).ready(function () {
    $("#btnAgregarMateria").click(function () {
        $("#formMateria").trigger("reset");
        $("#formulario").addClass("active show");
        $("#materias").removeClass("active");
        $("#navMaterias").removeClass("active");
        $("#navFormulario").addClass("active");
    })

 
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
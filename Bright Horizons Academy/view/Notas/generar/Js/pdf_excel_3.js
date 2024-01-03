$(document).ready(function () {

    $("#abrirPDF").on('submit', function () {
        var gradeid = $("#grade").val();
        var subjectid = $("#subject").val();
        var sectionid = $("#section").val();
        var studentid = $("#student").val();


        // Asigna los valores a los campos ocultos
        $("#gradeid").val(gradeid);
        $("#subjectid").val(subjectid);
        $("#sectionid").val(sectionid);
        $("#studenid").val(studentid);

        // Envar el formuaario al servidor
        return true;
    });

    $("#abrirExcel").on('submit', function () {
        var gradeid = $("#grade").val();
        var subjectid = $("#subject").val();
        var sectionid = $("#section").val();
        var studentid = $("#student").val();

        // Asigna los valores a los campos ocultos
        $("#gradeid").val(gradeid);
        $("#subjectid").val(subjectid);
        $("#sectionid").val(sectionid);
        $("#studenid").val(studentid);

        // Envar el formuaario al servidor
        return true;
    });

});
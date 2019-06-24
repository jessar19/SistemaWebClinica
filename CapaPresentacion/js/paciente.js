function addRowDT(data) {
    var tabla = $("#tbl_pacientes").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].IdPaciente,
            data[i].Nombres,
            data[i].ApPaterno + " " + data[i].ApMaterno,
            ((data[i].Sexo == 'M') ? "Masculino" : "Femenimo"),
            data[i].Edad,
            data[i].Direccion,
            ((data[i].Estado == true) ? "Activo" : "Inactivo")

        ]);
    }
}

function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "GestionarPaciente.aspx/ListarPacientes",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (data) {
            console.log(data.d);
            addRowDT(data.d);
        }
    });
}

//llamando a  la funcion de ajax al cargar el documento;

sendDataAjax();
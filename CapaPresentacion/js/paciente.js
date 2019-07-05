
var tabla, data;
function addRowDT(data) {
     tabla = $("#tbl_pacientes").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].IdPaciente,
            data[i].Nombres,
            data[i].ApPaterno + " " + data[i].ApMaterno,
            ((data[i].Sexo == 'M') ? "Masculino" : "Femenimo"),
            data[i].Edad,
            data[i].Direccion,
            '<button value="Actualizar" title="Actualizar" class="btn btn-primary btn-edit" data-target="#imodal" data-toggle="modal"><i class="fa fa-check-square-o" aria-hidden="true"></i></button>&nbsp;' +
            '<button value="Eliminar" title="Eliminar" class="btn btn-danger btn-delete"><i class="fa fa-minus-square-o" aria-hidden="true"></i></button>'
           
        ]);

        /* ((data[i].Estado == true) ? "Activo" : "Inactivo")   */
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
            //console.log(data.d);
            addRowDT(data.d);
            console.log(data);  
        }
    });
}

function updateDataAjax() {
    var obj = JSON.stringify({ id: JSON.stringify(data[0]), direccion: $("#txtModalDireccion").val()});
    $.ajax({
        type: "POST",
        url: "GestionarPaciente.aspx/ActualizarDatosPaciente",
        data: obj,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (response) {
            if (response.d) {
                alert("Registro actualizado correctamente.");
            } else {
                alert("Error en Actualizacion.");
            }
           

        }
       
    });
}

//evento click para actualizar registro
$(document).on('click', '.btn-edit', function (e) {
    e.preventDefault();
    var row = $(this).parent().parent()[0];
    data = tabla.fnGetData(row);
    fillModalData();

});

//evento click para eliminar registro
$(document).on('click', '.btn-delete', function (e) {
    e.preventDefault();
    var row = $(this).parent().parent()[0];
    var data = tabla.fnGetData(row);
   // console.log(data);
   // console.log($(this).parent().parent().children().first().text());
});

//cargar datos en el modal
function fillModalData() {
    $("#txtFullName").val(data[1] + "" + data[2]);
    $("#txtModalDireccion").val(data[5]);
}

//enviar informacion al servidor
$("#btnactualizar").click(function (e) {
    e.preventDefault();
    updateDataAjax();

});
//llamando a  la funcion de ajax al cargar el documento;

sendDataAjax(); 
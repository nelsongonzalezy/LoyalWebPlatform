$(document).ready(function () {
    $("#Activation").on("click", function () {
        enviarActivationControlador();
    });
});
function enviarActivationControlador() {


    var nuevaURL = "/Policies/Activation?CodigoCertificado=" +
        "@Model.CodigoCertificado";
    // window.location.href = nuevaURL;
    console.log(nuevaURL)
    $.get(nuevaURL, function (data) {
        // Colocar la vista parcial dentro del contenedor de la modal
        $("#modalContenido").html(data);

        // Mostrar la modal
        $("#miModal").modal('show');
    });
}

    function mostraralertActivation(e) {
        e.preventDefault();

        Swal.fire({
            title: '@webLoyal.Resources.language.Resources.AreYouSure',
            icon: 'question',
            showCancelButton: true,
            confirmButtonText: '@webLoyal.Resources.language.Resources.Yes',
            willClose: (confirmed) => {
                if (confirmed) {
                    const form = document.getElementById('Activation)');
                    const action = form.action; // Utilizar directamente el atributo action
                    const controller = form.getAttribute('asp-controller');

                    // Realizar la petición AJAX utilizando la dirección del formulario
                    $.ajax({
                        type: form.method, // Utilizar directamente el atributo method
                        url: action,
                        data: $(form).serialize(),
                        success: function (result) {
                            // Procesar la respuesta según tus necesidades
                            console.log(result);

                            // Puedes mostrar otro Swal.fire con el resultado si es necesario
                            Swal.fire({
                                title: result.title,
                                text: result.text,
                                icon: result.icon
                            }).then((response) => {
                                // Verificar si el usuario confirmó
                                if (response.isConfirmed) {
                                    // Actualizar la página actual después de la petición AJAX exitosa
                                    location.reload();
                                }
                            });

                        },
                        error: function () {
                            // Manejar errores si es necesario
                            console.error('Error en la petición AJAX');
                        }
                    });
                }
            }
        });
    }

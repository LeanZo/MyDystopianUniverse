$(function () {
    $('.conteudo-container')[0].style.height = $('.conteudo-container')[0].scrollHeight + 'px';
    CarregarPosts();
});

function CarregarPosts() {
	$.ajax({
		type: "POST",
		url: "/Home/CarregarPosts",
		success: function (response) {
			console.log(response);
		},
		error: function (req, status, error) {
			console.log(req.responseText);
		}
	});
}
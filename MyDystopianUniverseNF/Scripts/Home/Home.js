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
			var post = document.getElementById('post-id-1');
			post.children[0].textContent = response.Titulo;
			post.children[1].textContent = response.Conteudo;
		},
		error: function (req, status, error) {
			console.log(req.responseText);
		}
	});
}
$("#btn-id").click(function () {
  const uri = "https://reqres.in/api/users?page=2";
  $.getJSON(uri, function (json) {
    $("#data-id").html("");
    json.data.forEach(function (user) {
      $("#data-id").append("<ul><li>" + user.id + "--" + user.email + "<br>");
    });
  });
});

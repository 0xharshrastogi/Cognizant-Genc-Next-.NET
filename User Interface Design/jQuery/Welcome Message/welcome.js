$("#btnId").click(function () {
  const name = $("#txt").val();
  const message = '"Welcome ' + name + '!"';
  $("#address").html(message);
});

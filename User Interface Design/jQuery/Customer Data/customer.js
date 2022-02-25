$(".add-row").click(function () {
  const name = $("#name").val();
  const tr = "<tr><td><input type='checkbox' name='record'></td><td>" + name + "</td></tr>";
  $("#frm table tbody").append(tr);
});

$(".delete-row").click(function () {
  $("tr input:checked").remove();
});

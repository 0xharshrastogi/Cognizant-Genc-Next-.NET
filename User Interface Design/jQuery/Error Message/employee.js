$("#btn-id").click(function () {
  $.getJSON("employee.json", {
    error: function () {
      $("#err-id").html("Error Message: Not found");
    },
  });
});

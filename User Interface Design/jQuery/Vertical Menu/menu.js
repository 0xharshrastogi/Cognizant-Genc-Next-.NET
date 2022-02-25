const menus = $("#list > li > a");

$("#each_ex").click(function () {
  const messageBox = $("#msg_ex");
  menus.css("background-color", "red");
  const items = [];
  menus.each(function () {
    return items.push(this.innerText);
  });

  messageBox.html(items.join("<br />"));
});

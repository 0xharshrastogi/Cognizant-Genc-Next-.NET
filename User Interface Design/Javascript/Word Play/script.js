function wordPlay(range) {
  if (range < 1) return "Not Valid";
  if (range > 50) return "Range is High";

  var items = [];

  for (var i = 1; i <= range; i++)
    if (i % 15 === 0) items.push(" Jump");
    else if (i % 3 === 0) items.push(" Tap");
    else if (i % 5 === 0) items.push(" Clap");
    else items.push(` ${i}`);

  return items.join("");
}

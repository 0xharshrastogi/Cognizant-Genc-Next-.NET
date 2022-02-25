function modifyString(str) {
  return str.toLowerCase().split(" ").join("");
}

function uniqueCharacters(str) {
  const uniqueCharSet = new Set(modifyString(str));

  return [...uniqueCharSet.values()].join("");
}

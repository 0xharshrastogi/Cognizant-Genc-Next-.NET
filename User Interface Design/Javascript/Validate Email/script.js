const EMAIL_REGEX = /^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

function validateEmail(email) {
  return (EMAIL_REGEX.test(email) ? "Valid" : "Invalid") + " email address!";
}

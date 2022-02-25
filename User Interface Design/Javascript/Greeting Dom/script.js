function display() {
  const studentName = document.getElementById("sname").value;
  const courseName = document.getElementById("course").value;
  const outputElement = document.getElementById("greet");
  const noNameGreetMessage = "Name cannot be empty";

  outputElement.innerHTML = studentName === "" ? noNameGreetMessage : "Hi, " + studentName + ". You have successfully registered for the " + courseName + " course.";
}

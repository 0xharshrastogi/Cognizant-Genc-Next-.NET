class Employee {
  constructor(name, designation, year_of_experience) {
    this.name = name;
    this.designation = designation;
    this.year_of_experience = year_of_experience;
  }

  workingSince() {
    const currentYear = 2020;
    return currentYear - this.year_of_experience;
  }

  static isEmployee(emp) {
    return emp instanceof Employee;
  }
}

function createEmployee(name, designation, year_of_experience) {
  return new Employee(name, designation, year_of_experience);
}

function validateObject(emp) {
  return Employee.isEmployee(emp);
}

function displayEmployee(name, designation, year_of_experience) {
  const employee = createEmployee(name, designation, year_of_experience);

  if (!validateObject(employee)) return;

  const workingFromYear = employee.workingSince();
  return `${employee.name} is serving the position of ${employee.designation} since ${workingFromYear}`;
}

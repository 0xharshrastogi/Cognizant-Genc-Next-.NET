SELECT student_name, department_name
FROM Student, Department
WHERE Student.department_id = Department.department_id AND city = 'Coimbatore'
ORDER BY student_name;
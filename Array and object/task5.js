//5. Verilmis ishciler siyahisinda (ischiler obyekt seklindedir ve firstName,lastName,salary deyerleri var)
//maashi 500-den yuxari olan ishcileri ekrana cap eden alqoritm. (sadece JS proqramlashdirma dilinde)

let employee = [
  (employee1 = { firstName: "Sadiq", lastName: "Aliyev", salary: 450 }),
  (employee2 = { firstName: "Esmira", lastName: "Quliyeva", salary: 550 }),
  (employee3 = { firstName: "Farid", lastName: "Asadli", salary: 700 }),
];
for (let i = 0; i < employee.length; i++) {
  if (employee[i].salary > 500) {
    console.log(employee[i].firstName + " " + employee[i].lastName);
  }
}

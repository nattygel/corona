
const baseUrl = 'http://localhost:5263/api/';

document.addEventListener('DOMContentLoaded', registerEvents);

function registerEvents() {
  document.getElementById('ShowPatients').addEventListener('click', ShowPatients);
  document.getElementById('ShowPatientById').addEventListener('click', ShowPatientById);
  document.getElementById('DeletePatient').addEventListener('click', DeletePatient);
  document.getElementById('addPatient').addEventListener('click', AddPatient);
}

function ShowPatients(e) {
  e.preventDefault();
  fetch(`${baseUrl}Patients`, {
    method: 'GET',
    headers: {
      'Content-Type': 'application/json',
    }
  })
    .then(Response => Response.json())
    .then(patients => {
      console.log(patients);
      document.getElementById("show1").innerHTML = "";
      document.getElementById("show1").insertAdjacentHTML(
        `beforeend`,
        `<tr>
          <th>Patient ID</th>
          <th>Name</th>
          <th>Adress</th>
          <th>Date of Birth</th>
          <th>Phone Number</th>
          <th>Positive Result Date</th>
          <th>recovery Date</th>
          <th>vaccination 1</th>
          <th>Manufacturer</th>
          <th>vaccination 2</th>
          <th>Manufacturer</th>
          <th>vaccination 3</th>
          <th>Manufacturer</th>
          <th>vaccination 4</th>
          <th>Manufacturer</th>
        </tr>`
      );
      patients.forEach(element => {
        document.getElementById("show1").insertAdjacentHTML(`beforeend`,
          `<tr>
        <td>${element.id}</<td>
        <td>${element.firstName} ${element.lastName}</<td>
        <td>${element.city} ${element.street} ${element.houseNumber}</<td>
        <td>${element.dateOfBirth}</<td>
        <td>${element.phoneNumber}</<td>
        <td>${element.cellphone}</<td>
        <td>${element.covidInfoDTO.positiveResultDate}</<td>
        <td>${element.covidInfoDTO.recoveryDate}</<td>
        <td>${element.covidInfoDTO.vaccination1}</<td>
        <td>${element.covidInfoDTO.vaccine1Manufacturer}</<td>
        <td>${element.covidInfoDTO.vaccination2}</<td>
        <td>${element.covidInfoDTO.vaccine2Manufacturer}</<td>
        <td>${element.covidInfoDTO.vaccination3}</<td>
        <td>${element.covidInfoDTO.vaccine3Manufacturer}</<td>
        <td>${element.covidInfoDTO.vaccination4}</<td>
        <td>${element.covidInfoDTO.vaccine4Manufacturer}</<td>
        </tr>`
        )
      });
    })
    .catch(error => {
      console.log(error);
    });
}

function ShowPatientById(e) {
  e.preventDefault();
  const code = document.getElementById("id").value;
  fetch(`${baseUrl}Patients/${code}`, {
    method: 'GET',
    headers: {
      'Content-Type': 'application/json',
    }
  })
    .then(response => response.json())
    .then(patient => {
      console.log(patient);
      document.getElementById("show2").innerHTML = "";
      document.getElementById("show2").insertAdjacentHTML(`beforeend`,
        `<tr>
        <td>${patient.id}</<td>
        <td>${patient.firstName} ${patient.lastName}</<td>
        <td>${patient.city} ${patient.street} ${patient.houseNumber}</<td>
        <td>${patient.dateOfBirth}</<td>
        <td>${patient.phoneNumber}</<td>
        <td>${patient.cellphone}</<td>
        </tr>`
      )
    })
}

function DeletePatient(e) {
  e.preventDefault();
  const code = document.getElementById("id").value;
  fetch(`${baseUrl}Patients/${code}`, {
    method: 'DELETE',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(code)
  })
    .then(response => response.json())
    .then(patient => {
      console.log(patient);
      alert("Are you sure you want to delete patient?")
    })
}

function AddPatient(e) {
  e.preventDefault();
  const patient = collectData();
  fetch(`${baseUrl}Patients`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(patient)
  })
    .then(response => response.json())
    .then(patient => console.log(patient))
    .catch(error => console.log(error));
}

function collectData() {

  let id = document.getElementById('newId').value;
  let firstName = document.getElementById("firstName").value;
  let lastName = document.getElementById('lastName').value;
  let city = document.getElementById('city').value;
  let street = document.getElementById('street').value;
  let houseNumber = document.getElementById('houseNumber').value;
  let dateOfBirth = document.getElementById('dateOfBirth').value;
  let phoneNumber = document.getElementById('phoneNumber').value;
  let cellphone = document.getElementById('cellphone').value;

  return {
    Id: id,
    FirstName: firstName,
    LastName: lastName,
    City: city,
    Street: street,
    HouseNumber: houseNumber,
    DateOfBirth: dateOfBirth,
    PhoneNumber: phoneNumber,
    Cellphone: cellphone
  }
}
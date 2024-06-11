import React, { useState, useEffect } from 'react';
import './App.css';
import DtlStudentList from './components/DtlStudentList';
import DtlStudentForm from './components/DtlStudentForm';

function App() {
 

  const initialStudents = [
    { dtlId: 1, dtlName: "Đào thị thùy linh", dtlAge: 20, dtlIsActive: true },
    { dtlId: 2, dtlName: "Trần văn B", dtlAge: 21, dtlIsActive: false },
    { dtlId: 3, dtlName: "Đinh Văn C", dtlAge: 22, dtlIsActive: true },
    { dtlId: 4, dtlName: "Trần Thị D", dtlAge: 23, dtlIsActive: false },
  ];

  const [dtlListTasks] = useState(() => {
    const savedTasks = JSON.parse(localStorage.getItem("DtlTaskData"));
    return savedTasks ;
  });

  const [dtlListStudents, setDtlListStudents] = useState(() => {
    const savedStudents = JSON.parse(localStorage.getItem("DtlStudentData"));
    return savedStudents || initialStudents;
  });


  const [studentToEdit, setStudentToEdit] = useState(null);

  useEffect(() => {
    localStorage.setItem("DtlTaskData", JSON.stringify(dtlListTasks));
  }, [dtlListTasks]);

  useEffect(() => {
    localStorage.setItem("DtlStudentData", JSON.stringify(dtlListStudents));
  }, [dtlListStudents]);

  const dtlHandleSubmitStudent = (newStudent) => {
    if (studentToEdit) {
      setDtlListStudents(prevStudents =>
        prevStudents.map(student => (student.dtlId === newStudent.dtlId ? newStudent : student))
      );
    } else {
      setDtlListStudents(prevStudents => [
        ...prevStudents,
        { ...newStudent, dtlId: prevStudents.length ? prevStudents[prevStudents.length - 1].dtlId + 1 : 1 }
      ]);
    }
    setStudentToEdit(null);
  };

  const handleEditStudent = (student) => {
    setStudentToEdit(student);
  };

  const handleRemoveStudent = (studentId) => {
    setDtlListStudents(prevStudents =>
      prevStudents.filter(student => student.dtlId !== studentId)
    );
  };

  return (
    <div className="container border">
      <h1>Đào thị thùy linh cntt1</h1>
      <hr />
     
      <div>
        <DtlStudentList students={dtlListStudents} onEdit={handleEditStudent} onDelete={handleRemoveStudent} />
      </div>
      <div>
        <DtlStudentForm onSubmit={dtlHandleSubmitStudent} studentToEdit={studentToEdit} />
      </div>
    </div>
  );
}

export default App;

import React, { useState, useEffect } from 'react';

export default function DtlStudentForm({ onSubmit, studentToEdit }) {
  const [student, setStudent] = useState({ dtlId: '', dtlName: '', dtlAge: '', dtlIsActive: true });
  const [isEditing, setIsEditing] = useState(false);

  useEffect(() => {
    if (studentToEdit) {
      setStudent(studentToEdit);
      setIsEditing(true);
    } else {
      setStudent({ dtlId: '', dtlName: '', dtlAge: '', dtlIsActive: true });
      setIsEditing(false);
    }
  }, [studentToEdit]);

  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    setStudent(prevStudent => ({
      ...prevStudent,
      [name]: type === 'checkbox' ? checked : value
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    onSubmit(student);
  };

  return (
    <div className="card mt-4">
      <div className="card-header">
        <h2>{isEditing ? "Sửa Sinh viên" : "Thêm mới Sinh viên"}</h2>
      </div>
      <div className="card-body">
        <form onSubmit={handleSubmit}>
          <div className="form-group mb-3">
            <label>ID:</label>
            <input
              type="text"
              name='dtlId'
              value={student.dtlId}
              onChange={handleChange}
              className="form-control"
              required
            />
          </div>
          <div className="form-group mb-3">
            <label>Tên:</label>
            <input
              type="text"
              name='dtlName'
              value={student.dtlName}
              onChange={handleChange}
              className="form-control"
              required
            />
          </div>
          <div className="form-group mb-3">
            <label>Tuổi:</label>
            <input
              type="number"
              name='nmhAge'
              value={student.dtlAge}
              onChange={handleChange}
              className="form-control"
              required
            />
          </div>
          <div className="form-group mb-3">
            <label>Hoạt động:</label>
            <div className="form-check">
              <input
                type="checkbox"
                name='dtlIsActive'
                checked={student.nmhIsActive}
                onChange={handleChange}
                className="form-check-input"
              />
              <label className="form-check-label">Active</label>
            </div>
          </div>
          <button type='submit' className={`btn ${isEditing ? 'btn-warning' : 'btn-success'}`}>Lưu</button>
        </form>
      </div>
    </div>
  );
}

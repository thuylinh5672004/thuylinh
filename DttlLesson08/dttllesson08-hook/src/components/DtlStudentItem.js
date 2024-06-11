import React from 'react';

export default function DtlStudentItem({ student, onEdit, onDelete }) {
  return (
    <tr>
      <td>{student.dtlId}</td>
      <td>{student.dtlName}</td>
      <td>{student.dtlAge}</td>
      <td>{student.dtlIsActive ? 'Có' : 'Không'}</td>
      <td>
        <button className='btn btn-danger'  onClick={() => onEdit(student)}>Chỉnh sửa</button>
        <button className='btn btn-success' onClick={() => onDelete(student.dtlId)}>Xóa</button>
      </td>
    </tr>
  );
}

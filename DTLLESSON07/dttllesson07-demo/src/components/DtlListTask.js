import React, { useEffect, useState } from 'react';

export default function DtlListTask({ renderDtlListTasks, onDtlEdit }) {
    console.log(renderDtlListTasks);
    const [dtlList, setDtlList] = useState(renderDtlListTasks);

    useEffect(() => {
        setDtlList(renderDtlListTasks);
    }, [renderDtlListTasks]);

    const dtlHandleEdit = (param) => {
        console.log("Edit:", param);
        onDtlEdit();
    };

    let dtlElementTask = dtlList.map((task, index) => (
        <tr key={index}>
            <td>{index + 1}</td>
            <td>{task.dtl_taskId}</td>
            <td>{task.dtl_taskName}</td>
            <td>{task.dtl_taskLevel}</td>
            <td>
                <button className='btn btn-success' onClick={() => dtlHandleEdit(task)}>Edit</button>
                <button className='btn btn-danger'>Remove</button>
            </td>
        </tr>
    ));

    return (
        <div>
            <h2>Danh sách các nhiệm vụ</h2>
            <table className='table table-bordered'>
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Task ID</th>
                        <th>Task Name</th>
                        <th>Task Level</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {dtlElementTask}
                </tbody>
            </table>
        </div>
    );
}
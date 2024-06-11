import React,{ useEffect, useState} from 'react'

export default function DtlTaskAddOrEdit({dtlOnSubmit, renderDtlTask,renderDtlAddOrEdit}) {
    console.log(" DtlTaskAddOrEdit",renderDtlTask,renderDtlAddOrEdit);
    
    const dtlTaskObj={
        dtl_taskId:0,
        dtl_taskName:"",
        dtl_level:""
    }

    const [dtlTask,setDtlTask]=useState(dtlTaskObj);
    useEffect(()=>{
        setDtlTask(renderDtlTask);

    },[renderDtlTask]);
    console.log("State:",dtlTask);
    //ham su ly su kien thay doi tren dieu kien
    const dtlHandleChange= (dtlEvent)=>{
        let name =dtlEvent.target.name;
        let value =dtlEvent.target.value;

        setDtlTask(prev =>{
            return{
                ...prev,
                [name]:value,

            }
               
            
        })
    }
    const dtlHandleSubmit=(dtlEvent)=>{
        dtlEvent.preventDefault();
        dtlOnSubmit(dtlTask);
    }
    const dtlTitle =renderDtlAddOrEdit===true?"Them moi task":"sua staks";
  return (
        <div>
            <h2>{dtlTitle} </h2>
            <form>
                <div className="input-group mb-3">
                    <span className="input-group-text" id="basic-addon1">Task ID</span>
                    <input type="text" 
                        name='dtl_taskTd' value={dtlTask.dtl_taskId} onChange={dtlHandleChange}
                        class="form-control" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1"/>
                    </div>
                    <div className="input-group mb-3">
                    <span className="input-group-text" id="basic-addon1">Task ID</span>
                    <input type="text" 
                        name='dtl_taskName' value={dtlTask.dtl_taskName} onChange={dtlHandleChange}
                        class="form-control" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1"/>
                    </div>
                    <div className="input-group mb-3">
                        <label>Task Name</label>
                        <input name='dtl_taskName' value={dtlTask.dtl_taskName} onChange={dtlHandleChange}/>
                    </div>
                    <div>
                        <label>Task Level</label>
                        <select name='dtl_level' value={dtlTask.nhp_level} onChange={dtlHandleChange}>
                            <option value={'Small'}>Small</option>
                            <option value={'Medium'}>Medium</option>
                            <option value={'High'}>High</option>
                        </select>
                    </div>
                <button onClick={dtlHandleSubmit} className='btn btn-primary'>ghi lai</button>
            </form>
        
        </div>
    )
}


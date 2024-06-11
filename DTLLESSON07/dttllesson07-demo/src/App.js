import React from 'react';
import DtlListTask from './components/DtlListTask';
import DtlTaskAddOrEdit from './components/DtlTaskAddOrEdit';

function App() {
const dtl_listTasks = [
  {
    dtl_taskId: 2210900036,
    dtl_taskName: "Đào thị thùy linh",
    dtl_level: "Small",
  },
  {
    dtl_taskId: 1,
    dtl_taskName: "Học lập trình frontend",
    dtl_level: "Small",
  },
  {
    dtl_taskId: 2,
    dtl_taskName: "Học lập trình reactjs",
    dtl_level: "Medium",
  },
  {
    dtl_taskId: 3,
    dtl_taskName: "Lập trình với Frontend - Reactjs",
    dtl_level: "High",
  },
  {
    dtl_taskId: 4,
    dtl_taskName: "Lập trình Fullstack (PHP, Java, NetCore)",
    dtl_level: "Small",
  },
];
let data =  JSON.parse(localStorage.getItem("DtlK22CNT1DataTasks"));
  if(data === null || data.length === 0){
    data= dtl_listTasks;
    localStorage.setItem("DtlK22CNT1DataTasks",JSON.stringify(data))
  }
  // sử dụng hàm useState để lưu trữ trạng thái dữ liệu
  const [dtlListTasks, setDtlListTasks] = useState(data);
 
  useEffect(()=>{
    localStorage.setItem("DtlK22CNT1DataTasks",JSON.stringify(dtlListTasks))
  },[dtlListTasks])
// sử dụng hàm useState để lưu trữ trạng thái dữ liệu

// tạo state dữ liệu cho form (add, edit)
// Đối tượng task
const dtlTaksObj = {
  dtl_taskId: 0,
  dtl_taskName: "Môn",
  dtl_level: "Medium",
};
// Tạo state
const [dtlTask, setDtlTask] = useState(dtlTaksObj); // dữ liệu trên form
// state đê phân biệt trạng thái là thêm mới hay sửa
const [dtlIsAddOrEdit, setDtlIsAddOrEdit ] = useState(true); // mặc định ban đầu là form thêm mới

// Nhận dữ liệu khi sửa
const dtlHandleEdit = (param) => {
  console.log("App - Edit:", param);
  // Cập nhật lại tvcTask
  setDtlTask(param);
  // Cập nhật trạng thái form là sửa
  setDtlIsAddOrEdit(false);
};

const dtlHandleSubmit = (dtlParam) => {
  console.log("App:", dtlParam);
  if(dtlIsAddOrEdit===true){ // trường hợp thêm mới dữ liệu
    setDtlListTasks((prev) => {
      return [...prev, dtlParam];
    });
  }else{ // Trường hợp sử dụng dữ liệu
    for (let i = 0; i < dtlListTasks.length; i++) {
        if(dtlListTasks[i].dtl_taskId = dtlParam.dtl_taskId){
          dtlListTasks[i] = dtlParam;
          break;
        }
    }
    // Cập nhật lại state (thuListTasks)
    setDtlListTasks((prev) => {
      return [...prev];
    });
  }
};

// Hàm xóa
const dtlHandleDelete = (param)=>{
  let dtlResult = dtlListTasks.filter(x=>x.dtl_taskId != param.dtl_taskId);
  setDtlListTasks(dtlResult);
}
return (
  <div className="container border">
    <h1>Đào thị thùy linh</h1>
    <hr />
    <div>
      {/* Danh sách list task  */}
      <DtlListTask
        renderDtlListTasks={dtlListTasks}
        onDtlTaskEdit={dtlHandleEdit}
        onDtlTaskDelete = {dtlHandleDelete}
      />
    </div>
    <div>
      <DtlTaskAddOrEdit 
          renderDtlTask = {dtlTask}
          renderDtlIsAddOrEdit = {dtlIsAddOrEdit}

          dtlOnSubmit={dtlHandleSubmit} />
    </div>
  </div>
);

}
export default App;

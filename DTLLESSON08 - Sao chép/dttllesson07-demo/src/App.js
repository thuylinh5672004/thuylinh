import React from 'react';
import DtlListTask from './components/DtlListTask';
import DtlTaskAddOrEdit from './components/DtlTaskAddOrEdit';

const renderDtlListTasks = [
  {
    dtl_taskId: 1,
    dtl_taskName: 'Task 1',
    dtl_taskLevel: 'High',
  },
  {
    dtl_taskId: 2,
    dtl_taskName: 'Task 2',
    dtl_taskLevel: 'Medium',
  },
];

function App() {
  return (
    <div className="App">
      <DtlListTask renderDtlListTasks={renderDtlListTasks} onDtlEdit={() => console.log('Edit clicked')} />
    </div>
    
  );
}


export default App;

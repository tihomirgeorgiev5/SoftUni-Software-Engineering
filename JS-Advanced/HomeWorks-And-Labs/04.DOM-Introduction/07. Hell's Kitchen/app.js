function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick() {
      const inputElement = JSON.parse(document.querySelector('#inputs textarea').value);
      let avgSalary = 0;
      let totalSalary = 0;
      let currAvgSalary = 0;
      let bestName = '';
      let output = {};

      for (let line of inputElement) {
         /*PizzaHut - Peter 500, George 300, Mark 800 
           TheLake - Bob 1300, Joe 780, Jane 660 */
         let reastaurantInfo = line.split(' - ');
         let restaurantName = reastaurantInfo.shift();
         let workersInfo = reastaurantInfo[0].split(', ');

         for (let worker of workersInfo) {
            let [name, salary] = worker.split(' ');
            if (!output.hasOwnProperty(restaurantName)) {
               output[restaurantName] = {};
            }
            if (output.hasOwnProperty(restaurantName)) {
               output[restaurantName][name] = Number(salary);
            }
         }
      }

      let entries = Object.entries(output);

      for (let entry of entries) {
         let restName = entry[0];
         let salaryCurrentWorker = Object.values(entry[1]);

         for (let salary of salaryCurrentWorker) {
            totalSalary += salary;
         }
         avgSalary = totalSalary / salaryCurrentWorker.length;
         if (avgSalary > currAvgSalary) {
            currAvgSalary = avgSalary;
            bestName = restName;
            totalSalary = 0;
         }

      }
     

      

     
     let result = Object.entries(output[bestName])
         .sort((a, b) => b[1] - a[1]);
         console.log(result);
         
         let print = '';

      result.forEach(w =>
         print += `Name: ${w[0]} With Salary: ${w[1]} `);

      document.querySelector('#bestRestaurant p').textContent = `Name: ${bestName} Average Salary: ${currAvgSalary.toFixed(2)} Best Salary: ${(result[0][1]).toFixed(2)}`;

      document.querySelector('#workers p').textContent = print;
   }

}
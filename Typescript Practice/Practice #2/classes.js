"use strict";
// //-----------------------------Classes with Constructor-------------------------
Object.defineProperty(exports, "__esModule", { value: true });
// // class Car {
// //     name : string;
// //     year : number;
// //     constructor(name : string, year : number){
// //         this.name = name;
// //         this.year = year;
// //     }
// //     info(){
// //         console.log(`Car name is ${this.name} and model year is ${this.year}`)
// //     }
// // }
// // const car1 = new Car("Porsche",2025);
// // car1.info();
// //--------------------------Classes with interface------------------------------------
// // interface Model {
// //   getModel: () =>string;
// // }
// // class Audi implements Model {
// //   public name: string;
// //   public Color: string;
// //   constructor(name: string, Color: string) {
// //     this.name = name;
// //     this.Color = Color;
// //   }
// //    public getModel() : any{  
// //     console.log(`Car name is ${this.name} and color is ${this.Color}`);
// //   }
// // }
// // const car1 = new Audi("Audi A8","Black");
// // car1.getModel();
// //------------------------------Classes with modifiers---------------------------------
// class BankAccount{
//     readonly owner : string;
//     protected balance : number;
//     constructor( owner : string, balance : number){
//         this.owner = owner;
//         this.balance = balance;
//     }
//     Deposit(amount : number){
//         this.balance += amount;
//         console.log(`Deposit amount is $${amount} and new balance is $${this.balance}`);
//     }
//     Withdraw(amount : number){
//         this.balance -= amount;
//         console.log(`Withdraw amount is $${amount} and new balance is $${this.balance}`);
//     }
//     getBalance(){
//         return `${this.owner} balance is $${this.balance}`
//     }
// }
// const bank1 = new BankAccount("Numan Ijaz", 64000);
// bank1.Deposit(0);
// bank1.Withdraw(1500);
// console.log(bank1.getBalance());
// class BankAccountStatement extends BankAccount{
//     constructor(owner : string, balance : number , public age : number){
//         super(owner,balance);
//     }
//     getBalance1() {
//         return `${this.owner} have a statement of total balance is $${this.balance} and his age is ${this.age}`
//     }
// }
// const ext = new BankAccountStatement("Salman Ahmad",92000,23);
// console.log(ext.getBalance1());
// abstract class EmployeeDetails{
//     abstract getInfo() : string;
// }
// class BankEmployee{
//     private salary : number = 0;
//     constructor(public age : number, public name : string){
//         this.name = name;
//         this.age = age;
//     }
//     set Salary(amount : number){
//         if(amount < 0) throw new Error("Salary should not be negative.")
//             this.salary = amount;
//     }
//     get Salary(){
//         return this.salary;
//     }
//     getInfo<T>() {
//          console.log(`Bank Employee name is ${this.name} and his Age is ${this.age}`);
//     }
// }
// const empSalary = new BankEmployee(21,"Abdul Sami");
// empSalary.Salary = 212;
// console.log(empSalary.Salary);
// console.log(empSalary.getInfo());
// interface Person {
//   name: string;
//   age: number;
// }
// let obj:Person={
//   name:'Nauman',
//   age:20
// };
// function getPropValue(ob:Person,key:keyof Person){
//    return ob[key];
// }
// console.log(getPropValue(obj,'name'));
//# sourceMappingURL=classes.js.map
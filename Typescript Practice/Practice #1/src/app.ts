// ----------------------Simple Types---------------------------------------

// let message = "Hello TypeScript!";
// const big = 12983126391823719823;
// let float = 3.14;

// console.log(message);
// console.log(big);
// console.log(float);

// let sentense: string = `${message} ${float} ${hex} ${boolvalue} ${big}`;
// console.log(sentense);

//----------------------Explicit & Inference-----------------------------------

//in ["explicit"] we need to mention variable type for funnctions, objects and in return values

// let hex: number = 0x00032;
// console.log(hex);

// const uniqueKey : symbol = Symbol("Description");
// const obj = {
//     [uniqueKey] : "This is a Unique Property"
// }
// console.log(obj[uniqueKey]);

// function Sum(a : number, b : number){
//     return a + b;
// }
// Sum(5,2);

//in ["inference"] we dont need to mention variable type for simple declaration and assignments

// let boolvalue = true;
// console.log(boolvalue);

//-----------------------------Special Types-------------------------------

// function greet(name? : string){
//     return `Hello, ${name || 'Stranger'}`;
// }
// console.log(greet("Numan"));

// const Obj = {
//     Name : "Numan",
//     Age : 23,
//     Email : "numanijaz1564@gmail.com"
// };
// console.log(Obj.Name);
// console.log(Obj.Age);
// console.log(Obj.Email);

//-----------------------------Arrays-------------------------------------------

// const names = [];
// names.push({
//     Name : "Numan",
//     Age : 23,
//     Email : "numanijaz1564@gmail.com"
// });
// for(const Name of names){
//     console.log(Name);
// }
// console.log(names);

//--------------------------Tuples-------------------------------------------------

// let ObjectElements : [string, number, boolean];
// ObjectElements = ["Numan Ijaz", 21, false];

// console.log(ObjectElements);

//------------------------------Object Destructuring------------------------------------

// const person = ({
//     Name : "Salman",
//     Age : 34,
//     Country : "Pakistan"
// });

// let {Name , Age , Country} = person;
// document.getElementById("Object").innerHTML = Name + " " + Age + " " + Country;
// console.log(Name);
// console.log(Age);
// console.log(Country);

// const Car = ({
//     brand : "Audi",
//     model : 25,
//     year : 2025
// })

// let {brand, model, year} = Car;
// let carBrand = brand;
// console.log(carBrand);

// const product:any = ({
//     name : " Black Plain T-shirt",
//     price : 200.00,
// });

// let {name , price, stock =2} = product;
// console.log(name);
// console.log(price);
// console.log(`Stock Value is:`+ stock);

// const Employee = ({
//     id : 1,
//     personal: {
//         FirstName : "Numan",
//         LastName : "Ijaz"
//     },
//     position : "Developer"
// });

// let {FirstName, LastName} = Employee.personal;
// console.log(FirstName);

// function Book(title : string, author : string, year : number){

//     console.log(`${title} by ${author} release in ${year}`);
// }
// Book("atomic", "Numan", 2025);

//---------------------------Enums-------------------------------------------
// enum Status{
//     waiting = 1,
//     pending,                                                                     //PENDING
//     Complete
// };
// let gg=Status.Complete.toString();
// console.log(`Status is :`+gg);

//----------------------------Alias---------------------------------------

// type name = string;
// type age = number;
// type country = string;

// type person = {
//     Name : name,
//     Age : age,
//     Country : country
// }

// const user1name = "Numan Ijaz";
// const user1age = 21;
// const user1country = "Pakistan";

// const user1 : person = {
//     Name :user1name,
//     Age : user1age,
//     Country:'sasa'
// };

// console.log(user1);

// type id = number;
// type title = string;
// type price = number;
// type ID = number

// type Product = {
//     id : ID,
//     title : string,
//     dprice : price,
// }

// const product : Product = ({

//     id : 123,
//     title : "T shirt",
//     dprice : 12312
// });

// const ExObj : Product =
//     {id : 12, title : "Numna Ijaz", dprice : 1231.22};

// const ExObj1 = [
//     {id : 13, title : "Salman Khan", price : 1288},
// ];

// for(const all of Object.keys(ExObj)){

//     console.log((ExObj as any)[all]);

// }
// for(const all of ExObj1){

//     console.log(all);

// }

//------------------------------Interfaces---------------------------------------

// interface Cars{
//     Name : string,
//     Model : number,
// }

// interface CarColors extends Cars{
//     Color : string
// }

// const Audi : CarColors = {
//     Name : "Audi",
//     Model : 12,
//     Color : "Black"
// }

// console.log(Audi);

//---------------------------------Union Types------------------------------------------

//can be two datatypes at a one time

// function GetFullName(fullName : string | number){
//     console.log(`Your Name is ${fullName}`)
// }
// GetFullName("Numan Ijaz");
// GetFullName(1231);

//---------------------------------Functions-----------------------------------------

// function multiply(a : number, b : number, c? : number ){
//     return a + b +(c || 0);
// }
// console.log(multiply(2,3));

// function pow(value: number, exponent : number = 5){
//     return value ** exponent;
// }
// console.log(pow(2));

// function cars({porsche, nissan}: {porsche : string, nissan : string}){
//     return `The Porsche Color is ${porsche} and Nissan Color is ${nissan}`
// }
// console.log(cars({porsche :"Black", nissan : "White"}));

//-----------------------Rest Parameters--------------------------------                //PENDING

// function pow(a : number, b : number, ...rest : number[]){
//   return a + b + rest.reduce((p,c) => p + c, 0);
// }
// console.log(pow(2,2,123,123,123,12,312,321,3));


//-----------------------Casting----------------------------------------                //PENDING

//-----------------------Classes----------------------------------------                //PENDING



















//------------------------Utility------------------------------------

// interface Car{
//   name : string;
//   model : string;
// }

// let removeName : Pick<Car, "model"> = {
//   model : "2025",
// }
// console.log(removeName);

// let carInfo : Partial<Car> = {};
// carInfo.name = "Numan";


// interface Number{
//   n : number;
//   x : number;
// }

// let calculate : Required<Number> = {
//   n : 12,
//   x : 22,
// };


//--------------Utility Parameter----------------------        //PENDING
// let ss:string|null=null;

// console.log(ss??'sample');
// console.log(ss?ss:'sample');

// type Student={
//   FirstName:string
//   LastName?:string
//   BloodGroup?:{
//     Name:string
//   }

// };

// let dd:Student={
//     FirstName:'slaman'
// };
// console.log(dd.BloodGroup?.Name);


//-------------------------------Keyof and Null combine--------------------------        //PENDING

// type BankEmployee = {
//   name : string
//   age : number
//   department : string | null;
// }

// type BankEmployeeKeys = keyof BankEmployee;
// function getInfo(obj : BankEmployee, key : BankEmployeeKeys){

//   const value = obj[key];
//   if(value === null){
//     console.log(`${key} is empty right now.`);
//   }
//   else{
//     console.log(`${key} = ${value}`);
//   }

// }
// const info : BankEmployee = {name : "Numan Ijaz", age : 21, department : "BSIT"};
// getInfo(info, "department");


//---------------------------Conditional Types--------------------------------------

// const Data = ["Numan Ijaz", 21, true, null, undefined, "Mughal"];

// function simulateExtract(items : any, typeToExtract : any){

//     return items.filter((item: any) => typeof item === typeToExtract);

// };
// console.log(simulateExtract(Data,"string"));

// function simulateExclude(items : any , typeToExclude : any){
//     return items.filter((item:any) => typeof item !== typeToExclude);
// };

// console.log(simulateExclude(Data,"string"));

// function simulateNull(items : any){
//     return items.filter((item : any) => item !== null && item !== undefined);
// };

// console.log(simulateNull(Data));

// ------------------------types earased during compilation we can see just at runtime----------------

// type Value<T> = T extends "veg" ? "Veg Meal" : "Non Veg Meal";
// type a = Value<"veg">;
// type b = Value<"Non Veg">;


// type UnwrapPromise<T> = T extends Promise<infer D> ? D : T;
// type r = UnwrapPromise<Promise<string>>;
// type q = UnwrapPromise<Promise<number>>;


// type Permission<T> = T extends "admin"
// ? {canEdit : true, canDelete : true}
// : {canEdit : false, canDelete : false};

// type admin = Permission<"admin">;
// type user = Permission<"User">;


// type NestedCondition<T> =
// T extends string ? "You sent a string":
// T extends number ? "You sent a number":
// T extends boolean ? "You sent a boolean":
// "Unknow Type";

// type checkString = NestedCondition<"Numan">;
// type checkNumber = NestedCondition<123>;
// type checkBoolean = NestedCondition<true>;


//---------------------------------Logging system---------------------------------

// type system = "Production" | "Development";

// type CheckEnv<T> = T extends "Production" 
// ?{ message : string, timeStamp : Date}
// :{ message : string, timeStamp : Date , Debug : any};

// type Pro = CheckEnv<"Production">;
// type Dev = CheckEnv<"Development">;


// function log<T extends system>(env : T, log : CheckEnv<T>){
//     console.log(log);
// }

// log("Production", {message : "PRO MODE", timeStamp : new Date()} );
// log("Development", {message : "DEV MODE", timeStamp : new Date(), Debug : {a : 1 } } );


// type GetReturnType<T> = T extends (...args : any[]) => infer R ? R : never;

// type GetString = GetReturnType<string>;
// type GetNumber = GetReturnType<number>;






// type APISuccess = {success : boolean, data : string};
// type APIError = {success : boolean, error : string};

// type ApiResponse<T> = APISuccess | APIError;
// function fetchApi<T extends boolean>(simulatesuccess : T): ApiResponse<T>
// {
//     if(simulatesuccess)
//     {
//         return  {success : true, data : "Fetch API Successfully....."};
//     }
//     else
//     {
//         return { success: false, error: "Fetch API Error....." } as APIError;
//     }
// }
// const fetching = fetchApi(true);
// console.log(fetching);



//--------------------------------Mapped Types-------------------------------------

// interface Car{
//     name : string;
//     model : number;
//     id : number;
// }

// type CarMap = {
//     [P in keyof Car]?:Car[P];
// };

// const carMap : CarMap = {
//     name : "Numan",
//     id : 12,
// }
// for(const all of Object.keys(carMap)){
//     console.log(all);
// }


// type PickCar = Pick<Car, "name" | "model">;

// const pickCar : PickCar = {
//     name : "Numan",
//     model : 21
// }

// console.log(pickCar);

// interface ApiResponse{
//     data : number,
//     success : string,
//     error : string,
//     timestamp : unknown
// }

// type ConvertToString<T> = {
//     [P in keyof T] : T[P] extends number ? string : T[P];
// }

// const converted : ConvertToString<ApiResponse> ={
//     data : "numan",
//     success : "success",
//     error : "Error",
//     timestamp : 1290319,
// }
// console.log(converted);


// interface ReadValue{
//     readonly apiUrl : string,
//     readonly Success : string,
//     id?: number,
//     Date? : number,
// }

// type redval<T> = {
//     -readonly [P in keyof T] : T[P];
// };

// const val : redval<ReadValue> = {
//     apiUrl : "asdhakj9123",
//     Success : "success",
//     id : 12,
//     // Date : 12/31/2026,
// }
// console.log(val);
// console.log(typeof val.apiUrl);


//--------------------------------type inference-----------------------------

// let name = "Numan Ijaz";
// name = "Numan";
// console.log(name);

// const userName = "Samad" as const;
// // userName = "ubad";         // error
// console.log(userName);

// function GetCar<T>(name : T){
//     return name;
// }
// console.log(GetCar(true));

//---------------------------------literal Types----------------------------------

// let Car : "Porsche" | 12 | "Nissan";

// function Drive(Car : "Porsche" | 12 | "Nissan"){
//     if(typeof Car === "string"){
//         return `Drive ${Car}`;
//     }
//     else{
//         return `Number ${Car}`;
//     }    
// };

// console.log(Drive(12));
// console.log(Drive("Nissan"));


// type Statues = "Active" | "Pending" | "Completed";

// function GetStatues(statues : Statues){
//     switch(statues){
//         case "Active":
//             console.log("Your Account is Active...");
//             break;
//         case "Pending":
//             console.log("Your Account is on Pending...");
//             break;
//         case "Completed":
//             console.log("Your Account is Completed...");
//             break;
//     }
// }

// GetStatues("Active");
// GetStatues("Pending");
// GetStatues("Completed");


// type PaymentMethod = "Deposit" | "Withdraw" | "Transfer";
// let balance = 0;
// function GetPayment(type : PaymentMethod, amount : number){
//     if(type === "Deposit"){
//         if(amount >= 0)
//         {
//             balance += amount;
//             console.log(`Your $${amount} amount is Deposited.Total Balance is $${balance}`);
//         }
//         else
//         {
//             console.log("Your amount should be greater than 0!");
//         }
        
//     }
//     if(type === "Withdraw"){
//         if(amount <= balance && amount <= 0)
//         {
//             balance -= amount;
//             console.log(`Your $${amount} amount is Withdraw.New Total Balance is $${balance}`);
//         }
//         else
//         {
//             console.log("Your withdraw amount should not be greater than Balance amount.!");
//         }
        
//     }
//     if(type === "Transfer"){
//         balance -= amount;
//         console.log(`Your $${amount} amount is Transfered.New Total Balance is $${balance}`);
//     }
// }

// GetPayment("Deposit", 2000);
// GetPayment("Withdraw", 3000);
// GetPayment("Transfer", 500);


//--------------------------------Namespaces----------------------------

// namespace Calculator{
//     export namespace AddSub{
//         export function add(a : number, b: number)
//         {
//         return a + b;
//         }

//         export function subtract(a : number, b : number)
//         {
//         return a - b;
//         }
//     }
    
// }

// console.log(Calculator.AddSub.add(12,4));
// console.log(Calculator.AddSub.subtract(6,4));

//------------------------------ES/Modules or namespace---------------------------


// export function add(a : number, b: number){
//     return a + b;
// };

// export function subtract(a : number, b : number){
//     return a - b;
// };

// export function divide(a : number, b : number){   
//     return a / b;
// };

// export function multiply(a:number,b:number){
//     return a * b;
// };

//-------------------------------Index Signatures-------------------------------

// interface StudentInfo{
//     name : string,
//     id : number,
//     [otherInfo : string] : string | number
// }

// const Details : StudentInfo = {
//     name : "Numan",
//     id : 2712,
//     Age : 21,
//     Program : "BSIT",
//     Grade : "A+"
// }
// console.log(Details);

// interface ApiResponse{

//     [endpoint : string] : {
//         status : number,
//         data : any
//     }
// }

// const response : ApiResponse = {
//     "/users" : {status : 200 , data : [{id : 1, name : "Numan"}] },
//     "/posts" : {status : 404 , data: "Not Found"}
// }
// console.log(response);

//-----------------------------Declaration Merging--------------------------

// interface Student{
//     name : string,
//     age : number
// }

// interface Student{
//     id : number,
//     grade : string
// }

// const datInfo : Student = {
//     name : "Numan",
//     age : 21,
//     id : 3122,
//     grade : "A+"
// }
// console.log(datInfo);


// function greet(person : string) : string;
// function greet(person : string[]) : string[];
// function greet(person : any) : any {
//     return Array.isArray(person) ? person.map(p => `Hello, ${p}`) : `Hello ${person}`;
// };

// console.log(greet("Numan"));
// console.log(greet(["Ali", "Hamza"]));


//-------------------------Async Programming-----------------------------------

// const fetchData = ():Promise<string> =>{
//     return new Promise((resolve, reject) => {
//         setTimeout( () => resolve("Data Received"), 1000);
//     });
// };
// fetchData().then(console.log);

// async function Main(){
//     const result = await fetchData();
//     console.log(result);
// }
// Main();

// async function loadData(){
//     try{
//         const Data = await fetch("https://www.google.com/");
//         const json = await Data.json();
//         console.log(json);
//     }
//     catch(err){
//         console.error("Not Found",err);
//     }
// }
// loadData();


//---------------------------------Promises------------------------------------

// let PizzaPromise = new Promise((res, rej)=>{
    
//         let pizzaOrder = true;
//     if(pizzaOrder){
//         res("You order pizza!");
//     }
//     else
//     {
//         rej("Pizza Shop closed");
//     }
    
    
// });

// PizzaPromise
// .then((message) => console.log("Success : ", message))
// .catch((error)=> console.log("Error", error))
// .finally(()=>console.log("wait done for pizza!"));




// function PizzaPromisef(){
//     return new Promise((res,rej)=>{
//         console.log("You Ordering Pizza.....");
//         setTimeout(()=>{
//             res("Your pizza arrived in 3 seconds");
//             }
//              ,3000);
//     });
// }

// PizzaPromisef()
// .then((message) => console.log("Success : ", message))
// .catch((error)=> console.log("Error", error))
// .finally(()=>console.log("wait done for pizza!"));



// async function GetPizza(){
//     console.log("You Ordering Pizza.....");
//     let pizzaOrderPromise = await new Promise((res,rej) => {
//         setTimeout(() => res("Your pizza arrived in 5 seconds!") ,5000);  
//     });

//     console.log("Success: ",pizzaOrderPromise);
//     console.log("Let's Eat."); 
// };

// GetPizza();



// async function GetOrder(){
//     console.log("Ordering.....");
    
//     const pizza = await new Promise((resolve) => {setTimeout(() => resolve("pizza"),5000)});
//     const shake = await new Promise((resolve) => {setTimeout(() => resolve("shake"),2000)});

//     Promise.any([shake, pizza]).then((items) => console.log("All items ready: ",items));
// }
// GetOrder();



//----------------------------Decorators or C# Attributes----------------------------




function Entity(tableName: string) {
  return function(constructor: Function) {
    constructor.prototype.tableName = tableName;
  };
}

@Entity('users')
class User {
  id!: number;
  name!: string;
}

const u = new User();
console.log((u as any).tableName);
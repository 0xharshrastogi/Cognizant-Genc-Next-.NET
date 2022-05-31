import { Department } from "./Department";
import { Skill } from './Skill';

export interface Employee
{
    //Defining required properties.
    id:number;
    name:string;
    salary:number;
    permanent:boolean;
    department:Department;
    skill:Skill[];
    dateOfBirth:Date;
    // photoURL:string;
}
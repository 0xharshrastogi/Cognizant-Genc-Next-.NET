import { Department } from "./department";
import {Skill} from './skill'

export interface Employee{
    id:number;
    name:string;
    salary:number;
    permanent:boolean;
    dept:Department;
    dateOfbirth:Date;
    joiningDate:Date;
    skill:Skill[];
}
import { Department } from "./department";
import { Skill } from "./skill";

export interface IEmployee {
  id: number;
  name: string;
  salary: number;
  permanent: boolean;
  dept: Department;
  skill: Skill[];
}

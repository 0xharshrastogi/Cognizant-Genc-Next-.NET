export class Courses
{
    id:number | undefined;
    name:string | undefined;
    price:number | undefined;
    desc:string | undefined;
    constructor(id:number,name:string,price:number,desc:string)
    {
        this.id=id;
        this.name=name;
        this.price=price;
        this.desc=desc;
    }
}
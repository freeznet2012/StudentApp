export interface IStudent
{
    id: number;
    name: string;
    marks: Array<number>;
    total: number;
    result: boolean;
    marksAfterGrace: Array<number>;
    totalAfterGrace: number;
    resultAfterGrace: boolean;
}
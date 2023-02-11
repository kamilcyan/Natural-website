export interface Article {
    id: number;
    templateName: string;
    header: string;
    mainText: string;
    paragraph: string | null;
    mainImage: string | null;
    backgroundImage: string | null;
} 
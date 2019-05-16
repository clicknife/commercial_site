import Portfolio from '../../models/portfolio.model'

export interface PortfolioState extends Portfolio {
    loading:boolean;

    editable: boolean;
    edited: boolean;
    editing:boolean;

    selected: boolean;
    refreshing:boolean;

    create: boolean;

    error: boolean;
}

export  const initializePortfolioState  = function() {
    return {
        loading: false,
    
        editable: true,
        edited: false,
        editing:false,
    
        selected: false,
        refreshing:false,

        create: true,
        
        error: false,
    }
}

export interface iPortfolioState{
    portfolio: PortfolioState[];
    loading: boolean;
    pending: number;
}

export const  intializePortfolioState = function(){
    return {
        loading: false,
        pending: 0,
    }
}

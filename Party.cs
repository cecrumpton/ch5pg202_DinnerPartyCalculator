using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5pg202_DinnerPartyCalculator
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.5M) + 30M;
            return costOfDecorations;
        }
        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12)
                    totalCost += 100;
                return totalCost;
            }

        }

        //public virtual decimal Cost1
        //{
        //    get
        //    {
        //        decimal totalCost = CalculateCostOfDecorations();
        //        totalCost += CostOfFoodPerPerson * NumberOfPeople;
        //        decimal cakeCost;
        //        if (CakeSize() == 8)
        //            cakeCost = 40M + ActualLength * .25M;
        //        else
        //            cakeCost = 75M + ActualLength * .25M;
        //        return totalCost + cakeCost;
        //    }
        //}
        //
        //public virtual decimal Cost2
        //{
        //    get
        //    {
        //        decimal costOfBeveragePerPerson = CalculateCostOfBeveragesPerPerson();
        //        decimal totalCost = CalculateCostOfDecorations();
        //        totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
        //
        //        if (HealthyOption)
        //        {
        //            totalCost *= .95M;
        //        }
        //        return totalCost;
        //    }
        //}

    }
}

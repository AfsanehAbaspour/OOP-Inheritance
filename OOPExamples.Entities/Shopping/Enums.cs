using System;

namespace OOPExamples.Entities.Shopping
{
    /// <summary>
    /// انواع کارت عضویت و درصد تخفیف
    /// </summary>
   public enum EnMembershipCard : byte
    {
        /// <summary>
        /// 10 درصد تخفیف
        /// </summary>
        Blue  = 10,
        /// <summary>
        /// 20 درصد تخفیف
        /// </summary>
        Silver = 20,
        /// <summary>
        /// 30 درصد تخفیف
        /// </summary>
        Gold = 30
    }
}

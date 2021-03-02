using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Payment recieved")]
        PaymentRecieved,
        [EnumMember(Value = "Payment failed")]
        PaymentFailed
    }
}

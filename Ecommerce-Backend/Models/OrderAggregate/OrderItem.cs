﻿namespace Ecommerce_Backend.Models.OrderAggregate;

public class OrderItem
{
    public Guid Id { get; set; }
    public ProductItemOrdered ItemOrdered { get; set; }
    public long Price { get; set; }
    public int Quantity { get; set; }
}
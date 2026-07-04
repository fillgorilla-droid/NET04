Money money = new Money(8,0);
Money money1 = new Money(10,50);

class Money
{
    private int _money;
    private int _cent;

    public Money(int money, int cent)
    {
        this.money = money;
        this.cent = cent;
    }
    
    public Money()
    {
        _money = 0;
        _cent = 0;
    }

    public int money
    {
        get => _money;
        set
        {
            if (value >= 0) _money = value;
        }
    }

    public int cent
    {
        get => _cent;
        set
        {
            if (value >= 0)
            {
                var x_v = value;
                while (x_v >= 100)
                {
                    x_v -= 100;
                    money++;
                }
                _cent = x_v;
            }
        }
    }

    public static Money operator --(Money money)
    {
        money.cent--;
        return money;
    }

    public static Money operator ++(Money money)
    {
        money.cent++;
        return money;
    }

    public static Money operator +(Money money1, Money money2)
    {
        Money result = new Money();
        
        result.money = money1.money + money2.money;
        result.cent = money1.cent + money2.cent;
        
        result.cent_checker(result);
        return result;
    }

    public static Money operator -(Money money1, Money money2)
    {
        Money result = new Money();
        
        result.money = money1.money - money2.money;
        result.cent = money1.cent - money2.cent;
        
        result.cent_checker(result);
        return result;
    }

    public static Money operator *(Money money1, Money money2)
    {
        Money result = new Money();
        
        result.money = money1.money * money2.money;
        result.cent = money1.cent * money2.cent;
        
        result.cent_checker(result);
        
        return result;
    }

    public static Money operator /(Money money1, Money money2)
    {
        Money result = new Money();
        
        result.money = money1.money / money2.money;
        result.cent = money1.cent / money2.cent;
        
        result.cent_checker(result);
        return result;
    }

    public static Money operator %(Money money1, Money money2)
    {
        Money result = new Money();
        
        result.money = money1.money % money2.money;
        result.cent = money1.cent % money2.cent;
        
        result.cent_checker(result);
        return result;
    }

    public static bool operator true(Money money1)
    {
        return  money1.money != 0 || money1.cent != 0;
    }

    public static bool operator false(Money money1)
    {
        return  money1.money == 0 && money1.cent == 0;
    }

    public static bool operator ==(Money money1, Money money2)
    {
        if (money1.money == money2.money && money1.cent == money2.cent)
        {
            return true;
        }
        
        return false;
    }
    
    public static bool operator ==(Money money1, int dollars)
    {
        if (money1.money == dollars)
        {
            return true;
        }
        
        return false;
    }
    
    public static bool operator !=(Money money1, int dollars)
    {
        if (money1.money != dollars)
        {
            return true;
        }
        
        return false;
    }
    
    public static bool operator !=(Money money1, Money money2)
    {
        if (money1.money != money2.money && money1.cent != money2.cent)
        {
            return true;
        }
        
        return false;
    }
    
    
    public static bool operator >(Money money1, Money money2)
    {
        if (money1.money > money2.money || money1.cent > money2.cent)
        {
            return true;
        }
        
        return false;
    }

    public static bool operator >(Money money1, int dollars)
    {
        if (money1.money > dollars)
        {
            return true;
        }
        
        return false;
    }

    public static bool operator <(Money money1, int dollars)
    {
        if (money1.money < dollars)
        {
            return true;
        }
        
        return false;
    }
    
    public static bool operator <(Money money1, Money money2)
    {
        if (money1.money < money2.money || money1.cent < money2.cent)
        {
            return true;
        }
        
        return false;
    }
    
    public static bool operator <=(Money money1, Money money2)
    {
        if (money1.money <= money2.money && money1.cent <= money2.cent)
        {
            return true;
        }
        
        return false;
    }

    public static bool operator <=(Money money1, int dollars)
    {
        if (money1.money <= dollars)
        {
            return true;
        }
        return false;
    }

    public static bool operator >=(Money money1, int dollars)
    {
        if (money1.money >= dollars)
        {
            return true;
        }
        
        return false;
    }
    
    public static bool operator >=(Money money1, Money money2)
    {
        if (money1.money >= money2.money && money1.cent >= money2.cent)
        {
            return true;
        }
        
        return false;
    }

    public override string ToString()
    {
        return $"Dollar = ${money}, Cent = {cent}";
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return obj?.ToString() == this.ToString();
    }

    void cent_checker(Money money)
    {
        while (money.cent >= 100)
        {
            money.cent = money.cent - 100;
            money.money += 1;
        }
    }
}
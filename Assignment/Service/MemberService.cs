﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Entity;

namespace Assignment.Service
{
    // Thực hiện các chức năng liên quan đến member bao gồm:
    interface MemberService
    {
        // nhận tham số  đầu vào là, ra là..., có validate.
        String Login(String username, String password);

        Member Register(Member member);

        Member GetInformation(String token);
    }
}
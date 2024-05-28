﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IVisitor
    {
        void Visit(Apple apple);
        void Visit(Book book);
    }
}

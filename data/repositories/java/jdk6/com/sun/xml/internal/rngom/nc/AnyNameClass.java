/*
 * Copyright (c) 2005, 2006, Oracle and/or its affiliates. All rights reserved.
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 * This code is free software; you can redistribute it and/or modify it
 * under the terms of the GNU General Public License version 2 only, as
 * published by the Free Software Foundation.  Oracle designates this
 * particular file as subject to the "Classpath" exception as provided
 * by Oracle in the LICENSE file that accompanied this code.
 *
 * This code is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
 * version 2 for more details (a copy is included in the LICENSE file that
 * accompanied this code).
 *
 * You should have received a copy of the GNU General Public License version
 * 2 along with this work; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301 USA.
 *
 * Please contact Oracle, 500 Oracle Parkway, Redwood Shores, CA 94065 USA
 * or visit www.oracle.com if you need additional information or have any
 * questions.
 */
package com.sun.xml.internal.rngom.nc;

import javax.xml.namespace.QName;

final class AnyNameClass extends NameClass
{

    protected AnyNameClass() {} // no instanciation

    public boolean contains(QName name)
    {
        return true;
    }

    public int containsSpecificity(QName name)
    {
        return SPECIFICITY_ANY_NAME;
    }

    public boolean equals(Object obj)
    {
        return obj==this;
    }

    public int hashCode()
    {
        return AnyNameClass.class.hashCode();
    }

    public <V> V accept(NameClassVisitor<V> visitor)
    {
        return visitor.visitAnyName();
    }

    public boolean isOpen()
    {
        return true;
    }

    private static Object readReplace()
    {
        return NameClass.ANY;
    }
}

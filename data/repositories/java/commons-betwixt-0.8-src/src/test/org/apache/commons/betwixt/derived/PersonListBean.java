/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package org.apache.commons.betwixt.derived;

import java.util.ArrayList;
import java.util.List;

/** <p>Bean to test lists of people</p>
  *
  * @author Robert Burrell Donkin
  * @version $Revision: 438373 $
  */
public class PersonListBean
{

    private PersonBean owner;
    private ArrayList people = new ArrayList();

    public PersonListBean() {}

    public List getPersonList()
    {
        return people;
    }

    public void addPerson(PersonBean person)
    {
        people.add(person);
    }

    /**
     * @return PersonBean
     */
    public PersonBean getOwner()
    {
        return owner;
    }

    /**
     * Sets the owner.
     * @param owner The owner to set
     */
    public void setOwner(PersonBean owner)
    {
        this.owner = owner;
    }

}
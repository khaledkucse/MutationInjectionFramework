/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package org.apache.commons.transaction.memory;

/**
 * Exception displaying a conflict between two optimistic transactions.
 *
 * @version $Id: ConflictException.java 493628 2007-01-07 01:42:48Z joerg $
 * @see OptimisticMapWrapper
 */
public class ConflictException extends RuntimeException /* FIXME Exception*/
{
    protected Object key;

    public ConflictException(Object key)
    {
        this.key = key;
    }
}
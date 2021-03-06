//
//  KeyMagicNSString.h
//
//Copyright (C) 2008  KeyMagic Project
//http://keymagic.googlecode.com
//
//This program is free software; you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA

#import <Cocoa/Cocoa.h>
#include "KeyMagicTypes.h"

using namespace libkm;

@interface NSString (KeyMagicString_Addition)
+ (NSString*)stringWithKeyMagicString:(const KeyMagicString&)kString;
+ (NSString*)stringWithKeyMagicString:(const KeyMagicString&)kString maximumLength:(NSUInteger)length;
+ (NSString*)stringWithKeyMagicString:(const KeyMagicString&)kString maximumLength:(NSUInteger)length fromEnd:(BOOL)fromEnd;
- (KeyMagicString)getKeyMagicString;
@end

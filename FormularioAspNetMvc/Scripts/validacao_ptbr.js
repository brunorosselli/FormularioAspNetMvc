﻿jQuery.extend(jQuery.validator.methods, {
	number: function(value, element) {
		return this.optional(element) ||
            /^(\d{1,3}(\.\d{3})*|(\d+))(\,\d{2})?$/.test(value);
    }
});